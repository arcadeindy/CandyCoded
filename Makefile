build:
	Scripts/install_doxygen.sh
	Scripts/install_pandoc.sh
	Scripts/build_docs.sh
	Scripts/build_package.sh

docs:
	rm -rf Docs/ && doxygen doxygen.config

clean:
	rm -rf build/
	rm -rf Docs/
	rm -rf Library/
	rm -rf Packages/
	rm -rf ProjectSettings/
	rm -f test.xml
	rm -f unity.log

deploy:
	git subtree push --prefix Assets/Plugins/CandyCoded origin upm

.PHONY: docs
